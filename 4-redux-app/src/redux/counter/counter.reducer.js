const DataReducer = (
  state = {
    number: 0
  },
  action
) => {
  let newNumber = undefined;
  switch (action.type) {
    case "ADD_NUMBER":
      newNumber = state.number + action.payload;
      state = {
        ...state,
        number: newNumber
      };
      break;
    case "SUBSTRUCT_NUMBER":
      newNumber = state.number - action.payload;
      state = {
        ...state,
        number: newNumber
      };
      break;
    default:
      break;
  }
  return state;
};

export default DataReducer;
