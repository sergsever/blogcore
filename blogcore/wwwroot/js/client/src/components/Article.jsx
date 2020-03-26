import React, {Component} from 'react';
export default class Article extends Component
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

    UNSAFE_componentWillMount()
    {
        console.log('will mount:\n');
        var xhr = new XMLHttpRequest();
        xhr.open('GET', '/ArticlesAPI/GetCurrentArticle', true);
        xhr.send();
        console.log('will send:\n');
        xhr.onload = function() {
            console.log('will onload: status: ' + xhr.status);
            if (xhr.status != 200){
                console.log(xhr.status + xhr.statusText);
            }
            else{
                var article = JSON.parse(xhr.responseText);
                console.log('title:' + article.title);
                this.setState({title: article.title, text: article.text});
            }
        }.bind(this);
        

    }

    render()
    {
        console.log('title: ' + this.state.title);
        return( 
        <div>
        <h1>{this.state.title}</h1>
        <p>{this.state.text}</p>
        </div>);

    }


}

