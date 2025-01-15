import './App.css';
import {useState} from "react"
import 'bootstrap/dist/css/bootstrap.css';

function App() {

  const[array, setArray] = useState(["","Komedia","Obyczajowy","Sensacyjny","Horror"]);
  let value = 0;

  const onSumbit = (event) => {
    event.preventDefault();
    const {title, type} = event.target.elements;

    console.log({
      tytul : title.value, kategoria : type.value
    })
  }

  return (
    <div>
      <form onSubmit={onSumbit}>
        <div>
          <label htmlFor="title">Tytuł filmu</label>
          <input type="text" name="title" id="title" className='form-control'/>
        </div>
        <div>
          <label htmlFor="type">Rodzaj</label>
          <select id="type" name="type" className='form-control'>
          {array.map((element => <option value = {value++}> {element}</option>))}
          </select>
        </div>
        <button type="submit" className="btn btn-primary">Potwierdź</button>
      </form>
    </div>
  );
}

export default App;
