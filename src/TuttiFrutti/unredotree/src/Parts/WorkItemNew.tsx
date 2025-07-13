/* eslint-disable @typescript-eslint/no-unused-vars */
import type { WorkItemData, Tag } from "../App";
import WorkItemForm from "./WorkItemForm";

type NewWorkItemProps = {
    onSubmit: (data: WorkItemData) => void
    onAddTag: (tag: Tag) => void
    availableTags: Tag[]
}

function WorkItemNew({ onSubmit, onAddTag, availableTags } : NewWorkItemProps) {
    return (
        <>
            <h1 className="mb-4" >New WorkItem</h1>
            <WorkItemForm onSubmit={onSubmit} onAddTag={onAddTag} availableTags={ availableTags } />
        </>
  );
}

export default WorkItemNew;