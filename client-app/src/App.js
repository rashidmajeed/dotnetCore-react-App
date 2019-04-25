import React from 'react';
import { BrowserRouter, Route, Redirect } from 'react-router-dom';
import * as redux from 'redux';
import { Provider } from 'react-redux';
import  Navbar  from '../src/components/Shared/Navbar';
import RentalList from '../src/components/Rental/RentalList';
import RentalDetail from '../src/components/Rental/RentalDetail';
import './App.css';

class App extends React.Component {
	render() {
		const store = redux.createStore(() => {
			return {
				rentals: [{
					id: 1,
					title: "Central Apartment",
					city: "New York",
					street: "Times Sqaure",
					category: "apartment",
					image: "http://via.placeholder.com/350x250",
					bedrooms: 3,
					description: "Very nice apartment",
					dailyRate: 34,
					shared: false,
					createdAt: "24/12/2017"
				},
				{
					id: 2,
					title: "Central Apartment 2",
					city: "San Francisco",
					street: "Main street",
					category: "condo",
					image: "http://via.placeholder.com/350x250",
					bedrooms: 2,
					description: "Very nice apartment",
					dailyRate: 12,
					shared: true,
					createdAt: "24/12/2017"
				},
				{
					id: 3,
					title: "Central Apartment 3",
					city: "Bratislava",
					street: "Hlavna",
					category: "condo",
					image: "http://via.placeholder.com/350x250",
					bedrooms: 2,
					description: "Very nice apartment",
					dailyRate: 334,
					shared: true,
					createdAt: "24/12/2017"
				},
				{
					id: 4,
					title: "Central Apartment 4",
					city: "Berlin",
					street: "Haupt strasse",
					category: "house",
					image: "http://via.placeholder.com/350x250",
					bedrooms: 9,
					description: "Very nice apartment",
					dailyRate: 33,
					shared: true,
					createdAt: "24/12/2017"
				}]
			}
		});

		return (
			<Provider store={store}>
			<BrowserRouter>
				<div className="App">
					<Navbar />
					<div className='container'>
						<Route exact path='/' render={() => <Redirect to='/rentals' />} />
						<Route exact path='/rentals' component={RentalList} />
						<Route exact path='/detail:id' component={RentalDetail} />
					</div>
				</div>
			</BrowserRouter>
			</Provider>
		);
	}
}

export default App;
