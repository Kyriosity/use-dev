/* eslint-disable @typescript-eslint/no-unused-vars */
function UVal() {
    
    

    return (
      <>
            <div>Value</div>
            <div>Unit</div>
        </>
  );
}

export default UVal;

type Valuable = number
type Unitable = string

type UValue = Valuable & Unitable

function Calc(arg: Valuable & Unitable): never {

    throw new Error('only to stub the method');
}