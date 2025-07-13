import type { WorkItemData } from "../App";
import WorkItemForm from "./WorkItemForm";

type NewWorkItemProps = {
    onSubmit: (data : WorkItemData) => void
}

function WorkItemNew({ onSubmit } : NewWorkItemProps) {
    return (
        <>
            <h1 className="mb-4" >New WorkItem</h1>
            <WorkItemForm onSubmit={ onSubmit} />
        </>
  );
}

export default WorkItemNew;