import { useEffect, useState } from 'react'
export function useLocalStorage<T>(key: string, initVal: T | (() => T)) {
    const [value, setValue] = useState<T>(() => {
        const jsonValue = localStorage.getItem(key)
        if (jsonValue == null)
            return typeof initVal === "function" ? (initVal as () => T)() : initVal
        else
            return JSON.parse(jsonValue)
    });

    useEffect(() => {
        localStorage.setItem(key, JSON.stringify(value))
    }, [value, key])

    return [value, setValue] as [T, typeof setValue]
}