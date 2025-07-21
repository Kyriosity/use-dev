interface ISize {
    width: number
    height:number
}

type TSize = {
    width: number
    height: number
}


let square: ISize = { width: 5 , height: 5 }
let rectangulat = { width: 3, height: 8 } as ISize

const sq: TSize = square;


type Mix = string | number

let mix: Mix = "five"
mix = 5
// 🚫 mix = true