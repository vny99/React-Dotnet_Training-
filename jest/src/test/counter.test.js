import {fireEvent,screen,render} from "@testing-library/react"
import Counter from "../componants/Counter";
 // test block
 test("increment counter",()=>{
    //render the component on virtual dom
    render(<Counter/>);
    //select the elements you want interact with
    const counter=screen.getByTestId("counter");
    const incremntBtn=screen.getByTestId("increment");
    const decrementBtn=screen.getByTestId("decrement");
    fireEvent.click(incremntBtn);
    fireEvent.click(decrementBtn)
    expect(counter).toHaveTextContent("0");
    

 })