import { Warning } from "postcss"

type Thing = {
    id: number
   title? : string
}

type ThinggVariant = {
    id: number
    title: string | undefined
}


let thing: Thing = { id: 1 }
let variant: ThinggVariant = { id: 2, title: undefined } // must explicitly specify and prevent null default


type Enumerate<N extends number, Acc extends number[] = []> = Acc['length'] extends N
    ? Acc[number]
    : Enumerate<N, [...Acc, Acc['length']]>

type IntRange<F extends number, T extends number> = Exclude<Enumerate<T>, Enumerate<F>>

type Saturation = IntRange<25, 255>
let sat: Saturation = 254;


const Level = {
    Info: 'Info',
    Warn: 'Warn',
    Err: "Err"
} as const

type LogLevel = keyof typeof Level



type Return = ReturnType<typeof myfunc>

var myfunc = () => { }
