/* eslint-disable @typescript-eslint/no-unused-vars */
import 'bootstrap/dist/css/bootstrap.min.css'
import { Container } from 'react-bootstrap'
import { Routes, Route, Navigate } from 'react-router-dom'
import WorkItemNew from './Parts/WorkItemNew'
import { useLocalStorage } from './useLocalStorage'
import { useMemo } from 'react'
import { v4 as uuidV4 } from 'uuid' 

export type WorkItem = {
    id: string
} & WorkItemData

export type RawWorkItem = {
    id : string
} & RawWorkItemData

export type RawWorkItemData = {
    title: string
    markdown: string
    tagsIds : string[]
}

export type WorkItemData = {
    title: string
    markdown: string
    tags: Tag[]
}

export type Tag = {
    id: string
    label: string
}
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

    return <Container className="my-4">
        <Routes>
        <Route path="/" element={<h1>Un-Re-Do Tree</h1>} />
            <Route path="/new" element={<WorkItemNew onSubmit={ onCreateWorkItem} /> } />
        <Route path="/:id">
            <Route index element={ <h1>View </h1> } />
        <Route path="edit" element={<h1>Edit</h1>} />
        </Route>
        <Route path='/*' element={<Navigate to="/" /> } />
        </Routes>
    </Container>
}

export default App