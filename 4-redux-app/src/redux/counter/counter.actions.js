export function AddNumber(number) {
  return {
    type: "ADD_NUMBER",
    payload: number
  };
}

export function SubstructNumber(number) {
  return {
    type: "SUBSTRUCT_NUMBER",
    payload: number
  };
}
