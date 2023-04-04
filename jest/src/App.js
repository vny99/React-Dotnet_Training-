
import './App.css';
import Counter from './componants/Counter';
import Todos from './componants/Todo';
import "bootstrap/dist/css/bootstrap.min.css"

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <Counter/>
        <Todos/>
      </header>
    </div>
  );
}

export default App;
