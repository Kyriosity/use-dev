import WorkItemForm from "../Parts/WorkItemForm";
import { type NewWorkItemProps } from "../Types/Props/workiteming";

function WorkItemNew({ onSubmit, onAddTag, availableTags } : NewWorkItemProps) {
    return (
        <>
            <h1 className="mb-4" >New WorkItem</h1>
            <WorkItemForm onSubmit={onSubmit} onAddTag={onAddTag} availableTags={ availableTags } />
        </>
  );
}

export default WorkItemNew;