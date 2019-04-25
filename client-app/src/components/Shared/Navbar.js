import React from 'react';

function Navbar() {
return (		
	<nav className='navbar navbar-dark navbar-expand-lg'>
  <div className='container'>
    <a className='navbar-brand' href=''>HomeRent</a>
    <form className='form-inline my-2 my-lg-0'>
      <input className='form-control mr-sm-2 rental-search' type='search' placeholder='Try New York' aria-label='Search'></input>
      <button className='btn btn-outline-success my-2 my-sm-0 btn-rental-search' type='submit'>Search</button>
    </form>
    <button className='navbar-toggler' type='button' data-toggle='collapse' data-target='#navbarNavAltMarkup' aria-controls='navbarNavAltMarkup' aria-expanded='false' aria-label='Toggle navigation'>
      <span className='navbar-toggler-icon'></span>
    </button>
    <div className='collapse navbar-collapse' id='navbarNavAltMarkup'>
      <div className='navbar-nav ml-auto'>
	<button className='btn btn-success my-2 my-sm-0' href=''>Login <span className='sr-only'>(current)</span></button>
   <button className='btn btn-outline-primary my-2 my-sm-0 btn-rental-search' href=''>Register</button>
      </div>
    </div>
  </div>
</nav>
);
}
export default Navbar