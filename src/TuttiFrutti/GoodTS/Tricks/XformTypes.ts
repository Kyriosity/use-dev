interface Simple {
    id: number
    title: string
}

type ReadOnlyProps<T> = { 
    readonly [P in keyof T] : T[P] // 🪄 magic - can export to reuse in components
}


type ReadonlySimple = ReadOnlyProps<Simple>


// ENUM LIKE
const ODirection = {
    Up: "Up",
    Down: "Down",
    Left: "Left",
    Right: "Right",
} as const;


type Direction = typeof ODirection[keyof typeof ODirection];

function run(dir: Direction) { }

run(ODirection.Right);