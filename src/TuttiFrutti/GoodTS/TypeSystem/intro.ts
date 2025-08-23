// type parameters
const propType = <Obj, Key extends keyof Obj>(obj: Obj, key: Key): Obj[Key] => obj[key];

const res = propType({ id: 123 }, "id");

// @ts-expect-error 
let x: number = "Hello"

// @ts-expect-error ❌ 
let y: number = 5


type WildMix = string | boolean | 1
var mix1: WildMix = "test"
var mix1: WildMix = false
var mix1: WildMix = 1


namespace FuncsConjExample {

    let debouncedFn: Function & { cancel: Function }
// the same ->  let debouncedFn: (() => void) & { cancel: Function }

    debouncedFn = Object.assign(() => { }, { cancel: () => { } });

    // ✅
    debouncedFn();

    // ✅
    debouncedFn.cancel();

    // ❌ `unknownMethod` does not exist on `debouncedFn`.
    // @ts-expect-error
    debouncedFn.unknownMethod();

    // ❌ can't assign a string to `debouncedFn`.
    // @ts-expect-error: ❌
    debouncedFn = "Hello";
}

type MyRecord = { [key: string]: number }
let price: MyRecord = 'p': 1