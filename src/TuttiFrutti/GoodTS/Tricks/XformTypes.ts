interface Simple {
    id: number
    title: string
}

type ReadOnlyProps<T> = { 
    readonly [P in keyof T] : T[P] // 🪄 magic - can export to reuse in components
}


type ReadonlySimple = ReadOnlyProps<Simple>