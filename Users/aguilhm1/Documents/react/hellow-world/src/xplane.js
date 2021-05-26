import React, { Component } from 'react'
import TextField from '@material-ui/core/TextField'


export class xplane extends Component {
    constructor(props) {
        super(props)
    
        this.state = {
             textarea1:"hilda"
        }
    }
    
    clickme = () =>{
        console.log("you clicked me");
        this.setState({textarea1: "button pressed"})
    }

    render() {
        return (
            <div>
                <button onClick ={this.clickme}>
                    button
                </button>
                


                <TextField
                label="Log"
                value={this.state.textarea1}/>


            </div>
        )
    }
}

export default xplane
