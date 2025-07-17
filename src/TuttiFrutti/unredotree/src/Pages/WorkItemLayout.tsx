import { Navigate, useParams, Outlet } from "react-router-dom";
import { type ItemLayoutProps } from "../Types/Props/workiteming";

function WorkItemLayout({ items }: ItemLayoutProps) {
    const { id } = useParams()
    const item = items.find(it => it.id === id)

    if (item === null) return <Navigate to="/" replace />

    return <Outlet context={ item } />
}

export default WorkItemLayout;
