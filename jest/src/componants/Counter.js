import {React, useState} from "react";
import { Button } from "react-bootstrap";
const Counter =()=>{
   const [count,setCount]=useState(0);
    return(
        <>
       <Button data-testid="increment" onClick={()=>{setCount(count+1)}} >+</Button><p data-testid="counter" >{count}</p><Button data-testid="decrement" onClick={()=>{setCount(count-1)}}>-</Button>
        </>
    )
}
export default Counter;