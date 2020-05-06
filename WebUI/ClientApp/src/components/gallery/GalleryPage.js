import React, { Component } from 'react';
import { Col } from 'reactstrap';
import axios from 'axios';


class GalleryPage extends Component {
    state = {
        images: [

        ],

    }
    componentDidMount() {
        axios.get("/api/gallery")
            .then(res => {
                console.log(res);

this.setState({images: res.data});

            });

    }

    render() {
        const { images } = this.state;
        const content = images.map(item =>
            <div className="col-md-4" key={item.id} >

                <div className="card" >
                    <h5 className="card-title">{item.title}</h5>
                    <img className="card-img-top" src={item.url} alt="Card image cap" />
                    <div className="card-body">


                    </div>
                </div>
            </div>
        );

        return (
            <>
                <h1>Gallery</h1>
                <div className="row" >  {content}  </div>
            </>);
    }
}

export default GalleryPage;