import WorkItemForm from '../Parts/WorkItemForm'
import { useWorkItem } from '../Funcs/useWorkItem'
import type { EditWorkItemProps } from '../Types/Props/workiteming'

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