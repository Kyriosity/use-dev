type GeomShape = 
   | { form: "circle"; radius: number }
   | { form: "rect"; width: number, height: number }
    | { form: "square"; side: number }

type Unknown = { state: "Unknown" }
type Loading = { state: "Loading", start: Date  }

type Success = {
    state: "Succes"
    data: string
}
type Failed = {
    state: "Failed"
    code: number
}

type OpState = Unknown | Success | Loading | Error

// ---- UTILITY TYPES ---
// Partial
// Omit
// Readonly = here prebuilt
// Pick
// Awaited


