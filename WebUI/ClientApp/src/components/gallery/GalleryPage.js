import React, { Component } from 'react';


class GalleryPage extends Component {
    state = {
        images: [
            {
                id: 1,
                url: "https://avatars.mds.yandex.net/get-zen_doc/1657335/pub_5d90d04d8f011100ad16812d_5d90ddefdf944400ad95f764/scale_1200",
                title: "Oksana"
            },
            {
                id: 2,
                url: "https://www.biletik.aero/upload/resize_cache/medialibrary/227/compressed/22743d951e0d5711a029e686c7db39e7.jpg",
                title: "Yana+Lena"
            }

        ],

    }
    render() {
        const { images } = this.state;
        const content = images.map(item =>
            <div key={item.id} >
                <img src={item.url} />
            </div>
        );

        return (
            <>
                <h1>Gallery</h1>
                {content}
            </>);
    }
}

export default GalleryPage;