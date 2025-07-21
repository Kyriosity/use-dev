import { useState, useMemo } from 'react'
import { Row, Col, Stack, Button, Form} from 'react-bootstrap'
import { Link } from 'react-router-dom'
import ReactSelect from 'react-select'
import type { Tag } from '../Types/tagging'
import type { WorkItemsListProps } from '../Types/Props/workiteming'
import { EditTagsDialog } from '../Pages/Modal/EditTagsDialog'
import { ItemCard } from './ItemCard'

function WorkItemsList({ availableTags, items, onUpdateTag, onDeleteTag }: WorkItemsListProps) {
    const [title, setTitle] = useState("")
    const [selectedTags, setSelectedTags] = useState<Tag[]>([])

    const [editTagsModalIsOpen, setEditTagsModalIsOpen] = useState(false)

    const filteredItems = useMemo(() => {
        return items.filter(item => {
            return title === "" || item.title.toLowerCase().includes(title.toLowerCase()) &&
                (0 === selectedTags.length || selectedTags.every(tag => { item.tags.some(aTag => tag.id === aTag.id) }) )
        })
    }, [title, selectedTags, items]);

    return (
        <>
            <Row className="align-items-center mb-4">
                <Col>
                <h2>Work Items</h2>
                </Col>
                <Col xs="auto">
                    <Stack gap={ 2 } direction="horizontal">
                        <Link to="/new">
                            <Button variant="primary">New Workitem</Button>
                        </Link>
                        <Button onClick={() => setEditTagsModalIsOpen(true) } variant="outline-secondary">Edit Tags</Button>
                    </Stack>
                </Col>
            </Row>
            <Form>
                <Row className="mb-4">
                    <Col>
                        <Form.Group controlId="title">
                            <Form.Label>Searh by:</Form.Label>
                            <Form.Control type="text" value={title}
                                onChange={ ev => setTitle(ev.target.value) }
                            />
                        </Form.Group>
                    </Col>
                    <Col>
                        <Form.Group controlId="tags">
                            <Form.Label>Tags</Form.Label>
                            <ReactSelect isMulti
                                value={selectedTags.map(tag => { return { label: tag.label, value: tag.id } })}
                                options={availableTags.map(tag => { return { label: tag.label, value: tag.id } })}
                                onChange={tags => {
                                    setSelectedTags(tags.map(tag => {
                                        return { label: tag.label, id: tag.value }
                                    }))
                                }} />
                        </Form.Group>
                    </Col>
                </Row>
            </Form>
            <Row xs={1} sm={2} lg={3} xl={4} className="g-3">
                {filteredItems.map(item => (
                    <ItemCard key={item.id} id={item.id} title={item.title} tags={ item.tags } markdown="" />
                ))}
            </Row>
            <EditTagsDialog show={editTagsModalIsOpen}
                onDeleteTag={onDeleteTag} onUpdateTag={ onUpdateTag }
                handleClose={() => setEditTagsModalIsOpen(false)} availableTags={availableTags} />
      </>
  );
}

export default WorkItemsList;