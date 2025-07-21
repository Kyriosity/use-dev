import styles from '../../styling/select.module.css'
import { useEffect, useState, useRef } from 'react'

export type SelectOption = {
    label: string
    value: string | number
}

type SingleSelectProps = {
    multiple?: false
    value?: SelectOption
    onChange: (value: SelectOption | undefined) => void
}

type MultipleSelectProps = {
    multiple: true
    value: SelectOption[]
    onChange: (value: SelectOption[]) => void
}

type SelectProps = {
    options: SelectOption[]
} & (SingleSelectProps | MultipleSelectProps)

function SelectUnit({ multiple, value, onChange, options }: SelectProps) {
    const [isOpen, setIsOpen] = useState(false)
    const [highlightedIndex, setHighlightedIndex] = useState(0)
    const containerRef = useRef<HTMLDivElement>(null)

    useEffect(() => { if (isOpen) setHighlightedIndex(0) }, [isOpen])
    useEffect(() => {
        const handler = (evt: KeyboardEvent) => {
            if (evt.target !== containerRef.current) return
            switch (evt.code) {
                case "Enter":
                case "Space":
                    setIsOpen(prev => !prev)
                    if(isOpen) selectOption(options[highlightedIndex])
                    break
                case "ArrowUp":
                case "ArrowDown": { // ! to scope the declared variables! not to leak outside
                    if (!isOpen)
                        setIsOpen(true)
                    else {
                        const newIndex = highlightedIndex + ("ArrowDown" === evt.code ? 1 : -1)
                        if (0 <= newIndex && newIndex < options.length) setHighlightedIndex(newIndex)
                    }
                    break
                }
                case "Escape":
                    setIsOpen(false)
                    break
            }
        }
        containerRef.current?.addEventListener("keydown", handler)

        return () => { containerRef.current?.removeEventListener("keydown", handler) }
    }, [isOpen, highlightedIndex, options])

    function clearOptions() { multiple ? onChange([]) : onChange(undefined) }
    function selectOption(option: SelectOption) {
        if (multiple) {
            onChange([...value, option])
            if (value.includes(option))
                onChange(value.filter(item => item !== option))
        }
        else if (option !== value)
            onChange(option)
    }
    function isOptionSelected(option: SelectOption) {
        return multiple ? value.includes(option) : option === value
    }

    return <div ref={ containerRef } tabIndex={ 0 } className={ styles.container }
        onClick={() => setIsOpen(prev => !prev)} onBlur={ ()=>setIsOpen(false) } >
        <span className={styles.value}>{
            multiple ? value.map(item =>
             <button key={item.value} className={styles["option-badge"]}
                onClick={evt => { evt.stopPropagation; selectOption(item) }}>
                {item.label} <span className={ styles["remove-btn"] }>&times;</span>
            </button>)
                : value?.label
        } </span>
        <button className={styles["clear-btn"]}
            onClick={evt => { evt.stopPropagation(); clearOptions() }}>
            &times;</button>
        <div className={ styles.divider }></div>
        <div className={ styles.caret }></div>
        <ul className={`${styles.options} ${ isOpen ? styles.show : "" }`}>
            {options.map((option, index) => (
                <li key={option.value} className={`${styles.option} 
                ${ isOptionSelected(option) ? styles.selected : ""} 
                ${index === highlightedIndex ? styles.highlighte : "" }`}
                    onClick={evt => { evt.stopPropagation(); selectOption(option); setIsOpen(false); }}
                    onMouseEnter={ () =>  setHighlightedIndex(index) }>
                    {option.label}
                </li>))}
        </ul>
    </div>

}

export default SelectUnit;