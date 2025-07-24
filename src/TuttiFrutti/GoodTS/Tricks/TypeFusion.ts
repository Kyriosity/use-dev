type GeomShape = 
   | { form: "circle"; radius: number }
   | { form: "rect"; width: number, height: number }
    | { form: "square"; side: number }

// ---- UTILITY TYPES ---
// Partial
// Omit
// Readonly = here prebuilt
// Pick
// Awaited