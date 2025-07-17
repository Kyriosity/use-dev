import { useOutletContext } from 'react-router-dom';
import type { WorkItem } from "../Types/workiteming";

export function useWorkItem() {
    return useOutletContext<WorkItem>()
}