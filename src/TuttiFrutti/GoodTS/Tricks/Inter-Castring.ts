interface ISubject  {
    id: number
    title: string
    feat: boolean
}

type Subject = {
    id: number
    title: string
}


let ifaced: ISubject = { id: 1, title: "primus", feat: true }
const subjTwo: Subject = ifaced;

const free = { id: -5, title: "freefrom", feat: false }
ifaced = free

var anyone: ISubject | Subject