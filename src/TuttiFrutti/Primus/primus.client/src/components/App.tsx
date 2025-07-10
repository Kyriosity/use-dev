import { useEffect, useState } from 'react';
import './App.css';
import UVal from './Elements/UVal';
import Button from './Elements/Button';

interface MeasData {
    id: number;
    title: string;
    unitA: number;
    unitB: number;
}

function App() {
    const [measData, setMeasdata] = useState<MeasData[]>();

    // https://react.dev/reference/react/useEffect
    useEffect(() => {
        populateMeasData();
        alert('load data begins...');
    }, []);

    useEffect(() => {
        alert(`MeasData changed + ${measData?.length}`); }, [measData?.length]);


    const contents = measData === undefined
        ? <p>Check that the ASP.NET backend started and then refresh.</p>
        : <table className="table table-striped" aria-labelledby="tableLabel">
            <thead>
                <tr>
                    <th>Title</th>
                    <th>Unit A</th>
                    <th>Unit B</th>
                </tr>
            </thead>
            <tbody>
                {measData.map(item =>
                    <tr key={item.id}>
                        <td>{item.title}</td>
                        <td>{item.unitA}</td>
                        <td>{item.unitB}</td>
                    </tr>
                )}
            </tbody>
        </table>;

    return (
        <>
            <div>
            <h1 id="tableLabel">Measurement data</h1>
            <p>This component demonstrates fetching data from the server.</p>
            {contents}
            </div>
            <div>
                <Button name="pro forma" />
            </div>
            <div>
                <UVal />
            </div>
        </>

    );

    async function populateMeasData() {
        const response = await fetch('measdata') // .then(() => alert('loaded data')); // ToDo: remove literal
        if (response.ok) {
            const data = await response.json();
            setMeasdata(data);
        }
    }
}

export default App;