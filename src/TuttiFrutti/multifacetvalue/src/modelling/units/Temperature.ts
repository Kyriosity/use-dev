type Temperature = Readonly<{
    readonly Kelvin: 1,
    readonly Celcius: 2,
    Fahrenheit: 3
} & Units>


type Units = {
    readonly Unknown: 0
}

const Kelvin = "Kelvin"
type temper = "Kelvin" | "Celcius"
type extrTemp = "OHER" | temper

let te: temper = "Kelvin";

// #if DEBUG

class Tempo<T extends Units> {

}

let a = new Tempo<Temperature>

