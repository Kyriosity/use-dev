import type { Root } from "./Root"

export type Temperature = "Kelvin" | "Celcius" | "Fahrenheit" & Root

class UVal<T extends Root> { }

var a = new UVal<Temperature>()


