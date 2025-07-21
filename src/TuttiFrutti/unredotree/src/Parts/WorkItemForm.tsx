import { useState, useRef, type FormEvent } from 'react'
import { Form, Stack, Row, Col, Button } from 'react-bootstrap'
import { Link, useNavigate } from 'react-router-dom'
import CreateableReactSelect from 'react-select/creatable'
import type { Tag } from "../Types/tagging"
import { v4 as uuidV4 } from 'uuid' 
import type { WorkItemFormProps } from '../Types/Props/workiteming'

function WorkItemForm( { onSubmit, onAddTag, availableTags, title="", markdown="", tags=[] } : WorkItemFormProps ) {
    const titleRef = useRef<HTMLInputElement>(null)
    const markdownRef = useRef<HTMLTextAreaElement>(null)
    const [selectedTags, setSelectedTags] = useState<Tag[]>(tags)
    const navigate = useNavigate()

    function handleSubmit(ev : FormEvent) {
        ev.preventDefault()

        onSubmit({
            title: titleRef.current!.value,
            markdown: markdownRef.current!.value,
            tags: selectedTags
        })
        navigate("..")
    }

    return (
        <Form onSubmit={handleSubmit}>
          <Stack gap={4}>
              <Row>
                  <Col>
                      <Form.Group controlId="title">
                          <Form.Label>Title</Form.Label>
                            <Form.Control ref={ titleRef } required defaultValue={ title } />
                      </Form.Group>
                  </Col>
                  <Col>
                      <Form.Group controlId="tags">
                          <Form.Label>Tags</Form.Label>
                            <CreateableReactSelect isMulti
                                value={selectedTags.map(tag => { return { label: tag.label, value: tag.id } })}
                                options={availableTags.map(tag => { return { label: tag.label, value: tag.id } } )}
                                onCreateOption={label => {
                                    const newTag = { id: uuidV4(), label }
                                    onAddTag(newTag)
                                    setSelectedTags(prev => [...prev, newTag])
                                }}
                                onChange={tags => {
                                    setSelectedTags(tags.map(tag => {
                                        return { label: tag.label, id: tag.value }
                                    }))
                                }} />
                      </Form.Group>
                  </Col>
                </Row>
              <input type="text" />
              <Form.Group controlId="markdown">
                  <Form.Label>Body</Form.Label>
                    <Form.Control ref={markdownRef} required as="textarea" rows={15} defaultValue={ markdown } />
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