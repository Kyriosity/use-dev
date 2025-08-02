//import { Row, Col, Stack, Badge, Button, Container } from "react-bootstrap"

export type DemoProps = {
    id: string
}

function UnitsDemo({ id } : DemoProps) {
    return <h1>Units Demo { id }</h1>
}

export default UnitsDemo;