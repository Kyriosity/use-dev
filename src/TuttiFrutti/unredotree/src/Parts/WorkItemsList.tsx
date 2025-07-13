import { Row, Col, Stack, Button } from "react-bootstrap";
import { Link } from 'react-router-dom'

function WorkItemsList() {
    return (
        <>
            <Row>
                <Col>
                <h2>Work Items</h2>
                </Col>
                <Col xs="auto">
                    <Stack gap={2} direction="horizontal">
                        <Link to="/new">
                        <Button variant="primary">New Workitem</Button>
                        </Link>
                        <Button variant="outline-secondary">Edit Tags</Button>
                    </Stack>
                </Col>
            </Row>
      </>
  );
}

export default WorkItemsList;