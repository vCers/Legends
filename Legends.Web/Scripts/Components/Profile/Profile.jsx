﻿/*
	-----------------------------------
	Profile
	-----------------------------------
*/
class Profile extends React.Component {
	// --------------------------------
    constructor(props, context) {
        super(props, context);
        this.state = {};
    }

    // --------------------------------
    render() {
        return (
            <div className='view'>
                {/* Router View */}
                {this.props.children}
            </div>
        );
    }
}