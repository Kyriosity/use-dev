import styles from '../ItemsList.module.css'
import type { WorkItem } from '../Types/workiteming'
import { Stack, Card, Badge } from 'react-bootstrap'
import { Link } from 'react-router-dom'

export function ItemCard({ id, title, tags, markdown }: WorkItem) {
    return <Card as={ Link } to={`/${id}`} className={`h-100 text-reset text-decoration-none ${styles.card}}`}>
        <Card.Body><Stack gap={2} className="h-100 align-items-center justify-conten-center">
            <span className="fs-5">{title}</span>
            {tags.map(tag => (<Badge key={tag.id} className="text-truncate">{tag.label}</Badge>))}
        </Stack>
        </Card.Body>
    </Card>
}