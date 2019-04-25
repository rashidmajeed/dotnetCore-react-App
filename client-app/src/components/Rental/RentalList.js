import React from 'react';
import RentalCard from './RentalCard';
import { connect } from 'react-redux';

class RentalList extends React.Component {

	// funtion to iterate rental cards 
	renderRentals() {
	return this.props.rentals.map((rental, index) => {
			return (
				<RentalCard key={index} rental={rental} />
			);
		});
	}

	render() {
		return (
			<section id='rentalListing'>
				<h1 className='page-title'>Your Home All Around the World</h1>
				<div className='row'>
					{this.renderRentals()}

				</div>
			</section>
		);


	}
}

function mapStateToProps(state) {
	return {
		rentals: state.rentals
		}
}
export default connect(mapStateToProps)(RentalList);