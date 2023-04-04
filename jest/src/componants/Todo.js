import axios from "axios";
import React, { useEffect, useState } from "react";
import { Table } from "react-bootstrap";
const Todos=()=>{
    const [todos ,setTodos]=useState(null);
    useEffect(()=>{
        (async()=>{
            const todoList= await axios.get(
                "https://jsonplaceholder.typicode.com/todos"
            );
            setTodos(todoList.data);
            
        })();
    },[])
    return todos?(
      
       <Table striped bordered hover>
        <thead>
       <tr>
        <th>user id</th>
        <th>id</th>
        <th>titel</th>
        <th>completed</th>
       </tr>
       </thead>
       <tbody>
       {todos.map((todo,index)=>{
            return( <tr key={index} data-testid='todo' >
                <td>{todo.userId}</td>
                <td>{todo.id}</td>
                <td>{todo.title}</td>
                <td>{todo.completed}</td>
            </tr> )
         })}
        
       </tbody>
      
       </Table>
       
      
       
    ):(
        <p>Loading.....</p>
    )
}
export default Todos;