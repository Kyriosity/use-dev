import { Modal, Form, Stack, Row, Col, Button } from 'react-bootstrap'
import { type EditTagsModalProps } from '../../Types/Props/tagging'

export function EditTagsDialog({ availableTags, handleClose, show, onDeleteTag, onUpdateTag }: EditTagsModalProps ) {
    return <Modal show={ show } onHide = { handleClose } >
        <Modal.Header closeButton />
        <Modal.Title>Edit / Remove Tags </Modal.Title>
            < Modal.Body >
            <Form>
            <Stack gap={ 2 }>
                {
                    availableTags.map(tag => (<Row key= { tag.id } >
                        <Col>
                        <Form.Control type="text" value = { tag.label } onChange = { ev => onUpdateTag(tag.id, ev.target.value)
                } />
                </Col>
                < Col xs = "auto" >
                    <Button variant="outline-danger" onClick = { () => onDeleteTag(tag.id)}>& times; </Button>
    </Col>
    </Row>))}
</Stack>
    </Form>
    </Modal.Body>
    </Modal>
}