import React, { Component } from "react";
import { connect } from "react-redux";
import { AddNumber, SubstructNumber } from "./redux/counter/counter.actions";
import "./styles.css";

class App extends Component {
  render() {
    return (
      <div className="container mt-5">
        <div className="row">
          <button
            class="btn btn-dark"
            onClick={() => this.props.SubstructNumber_(1)}
          >
            Azalt
          </button>
          <p class="font-weight-bold pr-5 pl-5">{this.props.Data.number}</p>
          <button class="btn btn-dark" onClick={() => this.props.AddNumber_(1)}>
            Arttır
          </button>
        </div>
      </div>
    );
  }
}
const mapStateToProps = state => {
  return { Data: state.DataREDUCER };
};
const mapDispatchToProps = dispatch => {
  return {
    AddNumber_: num => {
      dispatch(AddNumber(num));
    },
    SubstructNumber_: num => {
      dispatch(SubstructNumber(num));
    }
  };
};
export default connect(
  mapStateToProps,
  mapDispatchToProps
)(App);
