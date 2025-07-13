import { useState, useRef, type FormEvent } from 'react'
import { Form, Stack, Row, Col, Button, } from 'react-bootstrap'
import { Link } from 'react-router-dom'
import CreateableReactSelect from 'react-select/creatable'
import type { WorkItemData } from "../App"

type WorkItemFormProps = {
    onSubmit: (data: WorkItemData) => void
}

function WorkItemForm( { onSubmit } : WorkItemFormProps ) {
    const titleRef = useRef<HTMLInputElement>(null)
    const markdownRef = useRef<HTMLTextAreaElement>(null)
    const [selectedTags, setSelectedTags] = useState<Tag[]>([])

    function handleSubmit(ev : FormEvent) {
        ev.preventDefault()

        onSubmit({
            title: titleRef.current!.value,
            markdown: markdownRef.current!.value,
            tags: []
        })
    }

    return (
        <Form onSubmit={handleSubmit}>
          <Stack gap={4}>
              <Row>
                  <Col>
                      <Form.Group controlId="title">
                          <Form.Label>Title</Form.Label>
                          <Form.Control ref={ titleRef} required />
                      </Form.Group>
                  </Col>
                  <Col>
                      <Form.Group controlId="tags">
                          <Form.Label>Tags</Form.Label>
                            <CreateableReactSelect isMulti
                                value={selectedTags.map(tag => { return { label: tag.label, value: tag.id } })}
                                onChange={tags => {
                                    setSelectedTags(tags.map(tag => {
                                        return { label: tag.label, id: tag.value }
                                    }))
                                }} />
                      </Form.Group>
                  </Col>
              </Row>
              <Form.Group controlId="markdown">
                  <Form.Label>Body</Form.Label>
                  <Form.Control ref={ markdownRef } required as="textarea" rows={ 15 } />
              </Form.Group>
              <Stack direction="horizontal" gap= { 2 } className="justify-content-end">
                  <Button type="submit" variant="primary">Save</Button>
                  <Link to="..">
                      <Button type="button" variant="outline-secondary">Cancel</Button>
                  </Link>
              </Stack>
          </Stack>
      </Form>
  );
}

export default WorkItemForm;