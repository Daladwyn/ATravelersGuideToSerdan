//import React from "react";
//import ReactDOM from "react-dom";

//let element = <h1>hello Talent</h1>;
//console.log(element);
//ReactDOM.render(element, document.getElementById('TalentWeapon'));
//Class Talent extends React.Component {
//    render() {
//        return (
//            <div className="">
//                <textarea>
//                    search Text
//                    </textarea>
//            </div>
//        );
//    }
//}

//ReactDom.render(
//    <Talent />,
//    Document.getElementById("TalentWeapon")
//);
'use strict';

const e = React.createElement;

class LikeButton extends React.Component {
    constructor(props) {
        super(props);
        this.state = { liked: false };
    }

    render() {
        if (this.state.liked) {
            return 'You liked this.';
        }

        return e(
            'button',
            { onClick: () => this.setState({ liked: true }) },
            'Like'
        );
    }
    const domContainer = document.querySelector('#TalentWeapon');
    ReactDOM.render(e(LikeButton), domContainer);
}