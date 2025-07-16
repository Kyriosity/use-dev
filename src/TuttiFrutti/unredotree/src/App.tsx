import { useMemo } from 'react'
import 'bootstrap/dist/css/bootstrap.min.css'
import { v4 as uuidV4 } from 'uuid'
import { Container } from 'react-bootstrap'
import { Routes, Route, Navigate } from 'react-router-dom'
import WorkItemNew from './Parts/WorkItemNew'
import WorkItemsList from './Parts/WorkItemsList'
import { useLocalStorage } from './Funcs/useLocalStorage'
import WorkItemLayout from './Parts/WorkItemLayout'
import WorkItem from './Parts/WorkItem'
import WorkItemEdit from './Parts/WorkItemEdit'
import type { Tag } from './Types/tagging'
import type { RawWorkItem, WorkItemData } from './Types/workiteming'

function App() {
    const [workItems, setWorkItems] = useLocalStorage<RawWorkItem[]>("WORKITEMS", [])
    const [tags, setTags] = useLocalStorage<Tag[]>("TAGS", [])

    const workItemsWithTags = useMemo(() => {
        return workItems.map(item => {
            return {
                ...item, tags: tags.filter(tag => item.tagsIds.includes(tag.id))
            }

        })
    }, [workItems, tags])

    function onCreateWorkItem({ tags, ...data }: WorkItemData) {
        setWorkItems(prev => { return [...prev, {...data, id: uuidV4(), tagsIds: tags.map(tag => tag.id)}] })
    }

    function onDeleteWorkItem(id: string) {
        setWorkItems(prev => {
            return prev.filter(item => item.id !== id)
        })
    }

    function onUpdateWorkItem(id: string, { tags, ...data }: WorkItemData) {
        setWorkItems(prev => {
            return prev.map(item => {
                return item.id === id ?
                    { ...item, ...data, tagsIds: tags.map(tg => tg.id) } : item
            })
        })
    }

    function updateTag(id: string, label: string) {
        setTags(prev => { return prev.map(tag => { return tag.id === id ? {... tag, label } : tag } ) })
    }

    function addTag(tag: Tag) {
        setTags(prev => [...prev, tag])
    }

    function deleteTag(id: string) {
        setTags(prev => { return prev.filter(tag => tag.id !== id) })
    }

    return <Container className="my-4">
        <Routes>
            <Route path="/" element={<WorkItemsList items={workItemsWithTags}
                availableTags={tags} onUpdateTag={ updateTag } onDeleteTag={ deleteTag  } />} />
            <Route path="/new" element={<WorkItemNew
                onSubmit={onCreateWorkItem}
                onAddTag={addTag}
                availableTags={tags} />} />
            <Route path="/:id" element={<WorkItemLayout items={ workItemsWithTags } />}>
                <Route index element={<WorkItem onDelete={ onDeleteWorkItem } />} />
                <Route path="edit" element={<WorkItemEdit
                    onSubmit={onUpdateWorkItem}
                    onAddTag={addTag}
                    availableTags={tags} 
                />} />
        </Route>
        <Route path='/*' element={<Navigate to="/" /> } />
        </Routes>
    </Container>
}

export default App