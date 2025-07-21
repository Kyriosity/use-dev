import { useState } from 'react'
import WorkItemForm from '../Parts/WorkItemForm'
import { useWorkItem } from '../Funcs/useWorkItem'
import type { EditWorkItemProps } from '../Types/Props/workiteming'
import SelectUnit from '../Parts/Elements/SelectUnit'
import type { SelectOption } from '../Parts/Elements/SelectUnit'

const ambient = [
    {label: "Kelvin", value: "K" },
    {label: "Celcius", value: "C" },
    {label: "Fahrenheit", value: "F" }
]

function WorkItemEdit({ onSubmit, onAddTag, availableTags }: EditWorkItemProps) {
    const item = useWorkItem()
    const [unit2, setUnit2] = useState<SelectOption | undefined>(ambient[0])
    const [unit1, setUnit1] = useState<SelectOption[]>([ambient[0]])

    return (
        <>
            <h1 className="mb-4" >Edit WorkItem</h1>

            <div><SelectUnit multiple options={ ambient } value={ unit1 } onChange={opt => setUnit1( opt )} /></div>
            <br />
            <div><SelectUnit options={ ambient } value={ unit2 } onChange={opt => setUnit2(opt)} /></div>

            <WorkItemForm
                title={ item.title }
                markdown={ item.markdown  }
                tags={ item.tags }
                onSubmit={data => onSubmit(item.id, data)} onAddTag={ onAddTag } availableTags={ availableTags } />
        </>
    );
}

export default WorkItemEdit;