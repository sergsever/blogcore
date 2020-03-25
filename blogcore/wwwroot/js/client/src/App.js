import React, {Component} from 'react'
import ReactDOM from 'react-dom'

class Article extends Component
{
    constructor(props)
    {
        super(props);
        var id = props.id;
        this.state = {id: props.id, title: '', text: '', date: null};
        if(id)
        {
        console.log("Article constructor state:" + this.state.id + '\n');
        }

    }

    componentDidMount()
    {
        var xhr = new XMLHttpRequest();
        xhr.open('GET', '/ArticlesAPI/GetCurrentArticle', true);
        xhr.send();
        xhr.onload = function() {
            if (this.readyState != 4)
                return false;
            console.log('status:' + this.status);
            if (this.status != 200){
                console.log(this.status + this.statusText);
            }
            else{
                var article = JSON.parse(this.responseText);
                console.log('title:' + article.date);
            }
        }
    }

        
        
            
            
         
    

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
ReactDOM.render(<Article id = {42} />, document.getElementById('Article'));
