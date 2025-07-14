import { Row, Col, Stack, Badge, Button } from "react-bootstrap";
import { Link, useNavigate } from 'react-router-dom'
import { useWorkItem } from "./WorkItemLayout";
import ReactMarkdown from 'react-markdown'


type WorkItemProps = {
    onDelete: (id: string) => void
}

function WorkItem({ onDelete } : WorkItemProps) {
    const item = useWorkItem()
    const navigate = useNavigate()

    return <>
        <Row className="align-items-center mb-4">
            <Col><h1>{item.title}</h1>
            {0 < item.tags.length && (
                <Stack gap={1} direction="horizontal" className="flex-wrap">
                    {
                        item.tags.map(tag => (<Badge key={tag.id} className="text-truncate">{tag.label}</Badge>)) 
                    }
                </Stack>
            )}
            </Col>
            <Col xs="auto">
                <Stack gap={2} direction="horizontal">
                    <Link to={`/${item.id}/edit`}>
                        <Button variant="primary">Edit</Button>
                    </Link>
                    <Button variant="outline-danger" onClick={() => { onDelete(item.id); navigate("/") } }>Delete</Button>
                    <Link to="/">
                        <Button variant="outline-secondary">Back</Button>
                    </Link>
                </Stack>
            </Col>
        </Row>
        <ReactMarkdown>{ item.markdown }</ReactMarkdown>
    </>
}

export default WorkItem;