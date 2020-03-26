import React, {Component} from 'react'
import ReactDOM from 'react-dom'
import Article from './components/Article.jsx'


export default class App extends Component
{
    render()
    {
        return( 
            <div>
                <h3>App</h3>
                <Article/>
            </div>
        );

    }
}
console.log('before ReactDom');
ReactDOM.render(<App />, document.getElementById('root'));
