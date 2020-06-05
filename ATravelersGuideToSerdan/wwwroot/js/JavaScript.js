//'use strict';

//const e = React.createElement;

//class DisplayTalang extends React.Component {
//    constructor(props) {
//        super(props);
//        this.state = {};
//    }

//    //render() {
//    //    return {
//    //        < div >
//    //        <input type="checkbox" name="Talang1"></input>
//    //        <label>talang for weapons</label>
//    //        <div>Description of this talang</div>
//    //    </div >
//    //    }
//}



//class LikeButton extends React.Component {
//    constructor(props) {
//        super(props);
//        this.state = { liked: false };
//    }

//    render() {
//        if (this.state.liked) {
//            return 'You liked this.';
//        }

//        //return (
//        //    <button onClick={() => this.setState({ liked: true })}>
//        //        Like
//        //    </button>
//        //);

//        return e(
//            'button',
//            { onClick: () => this.setState({ liked: true }) },
//            'Like'
//        );
//    }
//}
//let domContainer = document.querySelector('#TalentWeapon');
//ReactDOM.render(e(LikeButton), domContainer);