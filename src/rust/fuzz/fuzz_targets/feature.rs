#![no_main]

use flatgeobuf::*;
use libfuzzer_sys::fuzz_target;

fuzz_target!(|data: &[u8]| {
    let feature = get_root_as_feature(data);
    let _ = feature.geometry();
    let _ = match feature.properties() {
        Some(n) => n,
        None => return,
    };
});
