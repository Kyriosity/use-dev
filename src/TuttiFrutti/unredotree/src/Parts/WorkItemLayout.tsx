import { Navigate, useParams, Outlet, useOutletContext } from "react-router-dom";
import { type WorkItem } from "../App";

type ItemLayoutProps = {
    items : WorkItem[]
}

function WorkItemLayout({ items }: ItemLayoutProps) {
    const { id } = useParams()
    const item = items.find(it => it.id === id)

    if (item === null) return <Navigate to="/" replace />

    return <Outlet context={ item } />
}

export default WorkItemLayout;

export function useWorkItem() {
    return useOutletContext<WorkItem>()
}