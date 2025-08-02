import { BrowserRouter as Router, Routes, Route, Navigate } from 'react-router-dom'
import { Container } from 'react-bootstrap'
import UnitsDemo from './panes/UnitsDemo'

function App() {
    return (
        <Container className="my-4">
        <Router>
            <Routes>
                    <Route path="/A" element={<UnitsDemo id ="A" />} />
                <Route path="/B" element={<UnitsDemo id="B" />} />
                <Route path="/C" element={<UnitsDemo id="C" />} />
                <Route path="/*" element={<Navigate to="/" />} />
                </Routes>
            </Router >
        </Container>
    )
}

export default App
