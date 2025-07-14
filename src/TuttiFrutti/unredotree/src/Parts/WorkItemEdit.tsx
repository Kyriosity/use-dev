import type { WorkItemData, Tag } from "../App";
import WorkItemForm from "./WorkItemForm";
import { useWorkItem } from "./WorkItemLayout";

type EditWorkItemProps = {
    onSubmit: (id: string, data: WorkItemData) => void
    onAddTag: (tag: Tag) => void
    availableTags: Tag[]
}

function WorkItemEdit({ onSubmit, onAddTag, availableTags }: EditWorkItemProps) {
    const item = useWorkItem();
    return (
        <>
            <h1 className="mb-4" >Edit WorkItem</h1>
            <WorkItemForm
                title={ item.title }
                markdown={ item.markdown  }
                tags={ item.tags }
                onSubmit={data => onSubmit(item.id, data)} onAddTag={onAddTag} availableTags={availableTags} />
        </>
    );
}

export default WorkItemEdit;