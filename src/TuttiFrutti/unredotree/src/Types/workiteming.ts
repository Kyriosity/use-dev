import type { Tag } from "./tagging"

export type WorkItem = {
    id: string
} & WorkItemData

export type RawWorkItem = {
    id: string
} & RawWorkItemData

export type RawWorkItemData = {
    title: string
    markdown: string
    tagsIds: string[]
}

export type WorkItemData = {
    title: string
    markdown: string
    tags: Tag[]
}