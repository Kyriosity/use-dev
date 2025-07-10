export default function Button(props: { name: string}) {

  return (
      <button className="bg-blue-500">{props.name}</button>
  );
}