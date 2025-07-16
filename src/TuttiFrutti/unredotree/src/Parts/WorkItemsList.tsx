import { useState, useMemo } from "react"
import { Row, Col, Stack, Button, Form, Card, Badge } from "react-bootstrap"
import { Link } from 'react-router-dom'
import ReactSelect from 'react-select'
import type { WorkItem } from '../Types/workiteming'
import type { Tag } from '../Types/tagging'
import styles from '../ItemsList.module.css'
import type { WorkItemsListProps } from '../Types/Props/workiteming'
import { EditTagsDialog } from './Modal/EditTagsDialog'

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
            <Row classname="align-items-center mb-4">
                <Col>
                <h2>Work Items</h2>
                </Col>
                <Col xs="auto">
                    <Stack gap={2} direction="horizontal">
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
                    <ItemCard id={item.id} title={item.title} tags={ item.tags } markdown="" />
                ))}
            </Row>
            <EditTagsDialog show={editTagsModalIsOpen}
                onDeleteTag={onDeleteTag} onUpdateTag={ onUpdateTag }
                handleClose={() => setEditTagsModalIsOpen(false)} availableTags={availableTags} />
      </>
  );
}

function ItemCard({ id, title, tags, markdown }: WorkItem) {
    return <Card as={Link} to={`/${id}`} className={`h-100 text-reset text-decoration-none ${styles.card}}`}>
        <Card.Body><Stack gap={2} className="h-100 align-items-center justify-conten-center">
            <span className="fs-5">{title}</span>
            {tags.map(tag => (<Badge key={ tag.id } className="text-truncate">{ tag.label }</Badge>)) }
        </Stack>
        </Card.Body>
    </Card>
}

export default WorkItemsList;