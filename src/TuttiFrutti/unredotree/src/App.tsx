import 'bootstrap/dist/css/bootstrap.min.css'
import { Container } from 'react-bootstrap'
import { Routes, Route, Navigate } from 'react-router-dom'

function App() {
 
    return <Container className="my-4">
        <Routes>
        <Route path="/" element={<h1>Un-Re-Do Tree</h1>} />
        <Route path="/new" element={<h1>New element</h1>} />
        <Route path="/:id">
            <Route index element={ <h1>View </h1> } />
        <Route path="edit" element={<h1>Edit</h1>} />
        </Route>
        <Route path='/*' element={<Navigate to="/" /> } />
        </Routes>
    </Container>
}

export default App
