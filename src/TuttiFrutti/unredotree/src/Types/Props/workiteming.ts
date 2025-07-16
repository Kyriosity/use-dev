import type { Tag } from "../tagging"
import type { WorkItem, WorkItemData } from "../workiteming"

export type WorkItemsListProps = {
    availableTags: Tag[]
    items: WorkItem[]
    onDeleteTag: (id: string) => void
    onUpdateTag: (id: string, lable: string) => void
}

export type WorkItemProps = {
    onDelete: (id: string) => void
}

export type EditWorkItemProps = {
    onSubmit: (id: string, data: WorkItemData) => void
    onAddTag: (tag: Tag) => void
    availableTags: Tag[]
}

export type WorkItemFormProps = {
    onSubmit: (data: WorkItemData) => void
    onAddTag: (tag: Tag) => void
    availableTags: Tag[]
} & Partial<WorkItemData>

export type ItemLayoutProps = {
    items: WorkItem[]
}

export type NewWorkItemProps = {
    onSubmit: (data: WorkItemData) => void
    onAddTag: (tag: Tag) => void
    availableTags: Tag[]
}