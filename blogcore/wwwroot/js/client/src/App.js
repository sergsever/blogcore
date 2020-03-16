import React, {Component} from 'react'
import ReactDOM from 'react-dom'

class Article extends Component
{
    render()
    {
        return( 
        <div>
        <h1>Title</h1>
        <p>content</p>
        </div>);

    }
}
console.log('before ReactDom');
ReactDOM.render(<Article/>, document.getElementById('Article'));
