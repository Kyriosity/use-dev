import { BrowserRouter as Router, Routes, Route, Navigate } from 'react-router-dom'
import { Container } from 'react-bootstrap'
import UnitsDemo from './panes/UnitsDemo'

function App() {
    return (
        <Container className="my-4">
        <Router>
            <Routes>
                <Route path="/" element={<UnitsDemo />} />
                <Route path='/*' element={<Navigate to="/" />} />
                </Routes>
            </Router >
        </Container>
    )
}

export default App
