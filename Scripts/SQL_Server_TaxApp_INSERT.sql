-- Auth: John O'Neal
-- Date: 04/08/2024
-- Desc: This SQL Server script inserts example data into the tax application database for testing purposes.

-- Insert into users table
INSERT INTO users (
    username, password_hash, role
) VALUES (
    'username1', 'password1', 'Equity partner'
), (
    'username2', 'password2', 'Manager'
), (
    'testing', 'cf80cd8aed482d5d1527d7dc72fceff84e6326592848447d2dc0b0e87dfc9a90', 'Test role'
);

-- Insert into employees table
INSERT INTO employees (
	user_id, first_name, middle_name, last_name, address_line1, address_line2, city, state, zip,
    home_phone, mobile_phone, email
) VALUES (
	1, 'John', 'D', 'Doe', '123 Main St', 'Apt 4B', 'Anytown', 'NY', '12345',
    '555-555-5555','555-555-5555', 'john.doe@example.com'
), (
	2, 'Jane', 'E', 'Doe', '456 Elm St', 'Suite 789', 'Othertown', 'CA', '67890',
    '555-555-5555', '555-555-5555', 'jane.doe@example.com'
);

-- Insert into clients table
INSERT INTO clients (
	first_name, middle_name, last_name, suffix, ssn, birth_date, home_phone, mobile_phone,
    email, address_line1, address_line2, city, state, zip, occupation,
    routing_number, account_number, checking, savings, user_id
) VALUES (
	'Client', 'A', 'One', 'Sr.', '123-45-6789', '1980-01-01', '555-555-5555', '555-555-5555',
    'client.one@example.com', '123 Main St', 'Apt 4B', 'Anytown', 'NY', '12345', 'Occupation1',
    '123456789', '12345678901234567', 1, 0, 1
), (
    'Client', 'B', 'Two', 'Jr.', '987-65-4321', '1990-01-01', '555-555-5555', '555-555-5555',
    'client.two@example.com', '456 Elm St', 'Suite 789', 'Othertown', 'CA', '67890', 'Occupation2',
    '987654321', '98765432109876543', 0, 1, 2
);

-- Insert into invoice table
INSERT INTO invoices (
    client_id, employee_id, invoice_date, due_date, amount, paid, payment_date
) VALUES (
    1, 1, '2024-01-01', '2024-02-01', 500.00, 1, '2024-01-15'
), (
    2, 2, '2024-01-02', '2024-02-02', 600.00, 0, NULL
);

-- Insert into appointments table
INSERT INTO appointments (
    client_id, employee_id, date, time, purpose
) VALUES (
    1, 1, '2024-01-10', '10:00:00', 'Tax consultation'
), (
    2, 2, '2024-01-11', '11:00:00', 'Tax preparation'
);

-- Insert into w2 table
INSERT INTO w2 (
    client_id, tax_year, employer_ein, employer_name, employer_address_line1, employer_address_line2,
    employer_city, employer_state, employer_zip, control_number, wages, federal_tax_withheld,
    social_security_wages, social_security_tax_withheld, medicare_wages_and_tips, medicare_tax_withheld,
    social_security_tips, allocated_tips, dependent_care_benefits, non_qualified_plans,
    statutory_employee, retirement_plan, third_party_sick_pay, box_12a_code, box_12a_amount,
    box_12b_code, box_12b_amount, box_12c_code, box_12c_amount, box_12d_code, box_12d_amount,
    other, state, state_employer_id, state_wages, state_tax_withheld, local_wages, local_tax_withheld,
    local_name
) VALUES (
    1, 2021, '12-3456789', 'Example Employer 1', '123 Main St', 'Apt 4B', 'Anytown', 'NY', '12345',
    '1234', 50000.00, 5000.00, 50000.00, 3100.00, 50000.00, 725.00, 0.00, 0.00, 0.00, 0.00,
    0, 1, 0, 'A', 5000.00, 'B', 2000.00, 'C', 1500.00, 'D', 1000.00,
    'Other info', 'NY', '123456789', 50000.00, 2000.00, 0.00, 0.00,
    'Local Name 1'
), (
    2, 2021, '98-7654321', 'Example Employer 2', '456 Elm St', 'Suite 789', 'Othertown', 'CA', '67890',
    '5678', 60000.00, 6000.00, 60000.00, 3720.00, 60000.00, 870.00, 0.00, 0.00, 0.00, 0.00,
    0, 1, 0, 'A', 6000.00, 'B', 2400.00, 'C', 1800.00, 'D', 1200.00,
    'Other info', 'CA', '987654321', 60000.00, 2400.00, 0.00, 0.00,
    'Local Name 2'
);

-- Insert into schedule_d_metadata table
INSERT INTO schedule_d_metadata (
    client_id, tax_year, yes_disposal_of_opportunity_fund, no_disposal_of_opportunity_fund
) VALUES (
    1, 2024, 0, 1
), (
    2, 2024, 1, 0
);

-- Insert into schedule_d_short_term table
INSERT INTO schedule_d_short_term (
    schedule_d_metadata_id, form1099b_proceeds, form1099b_cost, form1099b_adjustment, form1099b_gain_loss,
    form8949_box_a_proceeds, form8949_box_a_cost, form8949_box_a_adjustment, form8949_box_a_gain_loss,
    form8949_box_b_proceeds, form8949_box_b_cost, form8949_box_b_adjustment, form8949_box_b_gain_loss,
    form8949_box_c_proceeds, form8949_box_c_cost, form8949_box_c_adjustment, form8949_box_c_gain_loss,
    gain_loss_forms6252_4684_6781_8824, net_gain_loss_schedule_k1, capital_loss_carryover,
    net_short_term_capital_gain_loss
) VALUES (
    1, 10000.00, 5000.00, 0.00, 5000.00,
    0.00, 0.00, 0.00, 0.00,
    0.00, 0.00, 0.00, 0.00,
    0.00, 0.00, 0.00, 0.00,
    0.00, 0.00, 0.00,
    5000.00
), (
    2, 20000.00, 10000.00, 0.00, 10000.00,
    0.00, 0.00, 0.00, 0.00,
    0.00, 0.00, 0.00, 0.00,
    0.00, 0.00, 0.00, 0.00,
    0.00, 0.00, 0.00,
    10000.00
);

-- Insert into schedule_d_long_term table
INSERT INTO schedule_d_long_term (
    schedule_d_metadata_id, form1099b_proceeds, form1099b_cost, form1099b_adjustment, form1099b_gain_loss,
    form8949_box_d_proceeds, form8949_box_d_cost, form8949_box_d_adjustment, form8949_box_d_gain_loss,
    form8949_box_e_proceeds, form8949_box_e_cost, form8949_box_e_adjustment, form8949_box_e_gain_loss,
    form8949_box_f_proceeds, form8949_box_f_cost, form8949_box_f_adjustment, form8949_box_f_gain_loss,
    gain_loss_forms4797_2439_6252_4684_6781_8824, net_gain_loss_schedule_k1, capital_gain_distributions,
    capital_loss_carryover, net_long_term_capital_gain_loss
) VALUES (
    1, 15000.00, 5000.00, 0.00, 10000.00,
    0.00, 0.00, 0.00, 0.00,
    0.00, 0.00, 0.00, 0.00,
    0.00, 0.00, 0.00, 0.00,
    0.00, 0.00, 0.00,
    0.00, 10000.00
), (
    2, 30000.00, 10000.00, 0.00, 20000.00,
    0.00, 0.00, 0.00, 0.00,
    0.00, 0.00, 0.00, 0.00,
    0.00, 0.00, 0.00, 0.00,
    0.00, 0.00, 0.00,
    0.00, 20000.00
);

-- Insert into schedule_d_summary table
INSERT INTO schedule_d_summary (
    schedule_d_metadata_id, total_gain_loss, yes_line15_16_both_gains, no_line15_16_both_gains,
    rate_gain_28_line7, unrecaptured_section1250_gain_line18, yes_line18_19_zero_and_not_filing_form4952,
    no_line18_19_zero_and_not_filing_form4952, line16_loss, yes_qualified_dividends_line3a,
    no_qualified_dividends_line3a
) VALUES (
    1, 15000.00, 0, 1,
    0.00, 0.00, 1,
    0, 0.00, 1,
    0
), (
    2, 30000.00, 1, 0,
    0.00, 0.00, 0,
    1, 0.00, 0,
    1
);

-- Insert into form1098e table
INSERT INTO form1098e (
    client_id, tax_year, corrected, recipient_name, recipient_address_line1, recipient_address_line2,
    recipient_city, recipient_state, recipient_zip, recipient_phone, recipient_tin, borrower_tin,
    account_number, student_loan_interest_received_by_lender, box2
) VALUES (
    1, 2024, 0, 'Lender 1', '123 Main St', 'Apt 4B', 'Anytown', 'NY', '12345', '555-555-5555',
    '12-3456789', '98-7654321', '12345678901234567', 500.00, 0
), (
    2, 2024, 0, 'Lender 2', '456 Elm St', 'Suite 789', 'Othertown', 'CA', '67890', '555-555-5555',
    '98-7654321', '12-3456789', '98765432109876543', 600.00, 0
);

-- Insert into schedule_k1 table
INSERT INTO schedule_k1 (
    client_id, tax_year, final_k1, amended_k1, beginning_date, ending_date, estate_or_trust_ein,
    estate_or_trust_name, fiduciary_name, fiduciary_address_line1, fiduciary_address_line2,
    fiduciary_city, fiduciary_state, fiduciary_zip, d_1041t_filed, d_date_filed, e_final_form1041,
    beneficiary_id, beneficiary_name, beneficiary_street_address, beneficiary_city, beneficiary_state,
    beneficiary_zip, h_domestic_beneficiary, h_foreign_beneficiary, interest_income, ordinary_dividends,
    qualified_dividends, net_short_term_capital_gain, net_long_term_capital_gain, rate_28_gain,
    other_portfolio_and_non_business_income, ordinary_business_income, net_rental_real_estate_income,
    other_rental_income, directly_apportioned_deductions, estate_tax_deduction, final_year_deductions,
    alternative_minimum_tax_adjustment, credits_credit_recapture, other_information
) VALUES (
    1, 2024, 1, 0, '2024-01-01', '2024-12-31', '12-3456789',
    'Estate 1', 'Fiduciary 1', '123 Main St', 'Apt 4B',
    'Anytown', 'NY', '12345', 1, '2024-01-15', 1,
    '123-45-6789', 'Beneficiary 1', '123 Main St', 'Anytown', 'NY',
    '12345', 1, 0, 1000.00, 2000.00,
    1500.00, 500.00, 1000.00, 0.00,
    0.00, 2000.00, 1000.00,
    0.00, 0.00, 0.00, 0.00,
    0.00, 0.00, 'Other info 1'
), (
    2, 2024, 0, 1, '2024-01-01', '2024-12-31', '98-7654321',
    'Estate 2', 'Fiduciary 2', '456 Elm St', 'Suite 789',
    'Othertown', 'CA', '67890', 0, NULL, 0,
    '987-65-4321', 'Beneficiary 2', '456 Elm St', 'Othertown', 'CA',
    '67890', 0, 1, 2000.00, 3000.00,
    2500.00, 1000.00, 2000.00, 0.00,
    0.00, 3000.00, 2000.00,
    0.00, 0.00, 0.00, 0.00,
    0.00, 0.00, 'Other info 2'
);

-- Insert into form1040 table
INSERT INTO form1040 (
    client_id, beginning_month_day, ending_month_day, ending_year_last_2_digits, address_line1,
    address_line2, city, state, zip, foreign_country_name, foreign_province_state_county,
    foreign_postal_code, you_presidential_election_fund, spouse_presidential_election_fund,
    single, married_filing_jointly, married_filing_separately, head_of_household,
    qualifying_surviving_spouse, filing_status_name, yes_digital_asset_transaction,
    no_digital_asset_transaction, you_as_a_dependent, spouse_as_a_dependent, spouse_itemizes,
    born_before_jan2_1959, blind, spouse_born_before_jan2_1959, spouse_blind, more_than_4_dependents
) VALUES (
    1, '01-01', '12-31', '24', '123 Main St', 'Apt 4B', 'Anytown', 'NY', '12345', NULL,
    NULL, NULL, 0, 0,
    1, 0, 0, 0,
    0, 'Single', 0,
    1, 0, 0, 0,
    0, 0, 0, 0, 0
), (
    2, '01-01', '12-31', '24', '456 Elm St', 'Suite 789', 'Othertown', 'CA', '67890', NULL,
    NULL, NULL, 0, 0,
    0, 1, 0, 0,
    0, 'Married filing jointly', 1,
    0, 0, 0, 0,
    0, 0, 0, 0, 0
);

-- Insert into form1040_dependents table
INSERT INTO form1040_dependents (
    form1040_id, first_name, last_name, ssn, relationship, child_tax_credit, credit_for_other_dependents
) VALUES (
    1, 'Dependent', 'One', '123-45-6789', 'Child', 1, 0
), (
    2, 'Dependent', 'Two', '987-65-4321', 'Spouse', 0, 1
);

-- Insert into form1040_income table
INSERT INTO form1040_income (
    form1040_id, total_w2_income, household_employee_wages, tip_income, medicaid_waiver_payments,
    dependent_care_benefits, adoption_benefits, form8919_wages, other_earned_income, combat_pay_election,
    total_earned_income, tax_exempt_interest, taxable_interest, qualified_dividends, ordinary_dividends,
    ira_distributions, taxable_ira_distributions, pensions_annuities, taxable_pensions_annuities,
    social_security_benefits, taxable_social_security_benefits, lump_sum_election, schedule_d_not_required,
    capital_gain_loss, additional_income, total_income, adjustments_to_income, adjusted_gross_income,
    standard_or_itemized_deduction, qualified_business_income_deduction, taxable_income
) VALUES (
    1, 50000.00, 0.00, 0.00, 0.00,
    0.00, 0.00, 0.00, 0.00, 0.00,
    50000.00, 0.00, 1000.00, 0.00, 2000.00,
    0.00, 0.00, 0.00, 0.00,
    0.00, 0.00, 0, 1,
    0.00, 0.00, 52000.00, 0.00, 52000.00,
    12400.00, 0.00, 39600.00
), (
    2, 60000.00, 0.00, 0.00, 0.00,
    0.00, 0.00, 0.00, 0.00, 0.00,
    60000.00, 0.00, 2000.00, 0.00, 3000.00,
    0.00, 0.00, 0.00, 0.00,
    0.00, 0.00, 0, 1,
    0.00, 0.00, 65000.00, 0.00, 65000.00,
    24800.00, 0.00, 40200.00
);

-- Insert into form1040_tax_payments table
INSERT INTO form1040_tax_payments (
    form1040_id, tax, box1_8814, box2_4972, box3_, box3_form_number, schedule2_amount, line18_total,
    child_tax_credit, schedule3_amount, line21_total, line22_result, other_taxes, total_tax,
    form_w2_federal_income_tax_withheld, form1099_federal_income_tax_withheld,
    other_forms_federal_income_tax_withheld, total_federal_income_tax_withheld, estimated_tax_payments,
    earned_income_credit, additional_child_tax_credit, american_opportunity_credit, schedule3_line15_amount,
    total_other_payments_refundable_credits, total_payments, overpaid_amount, refund_request_amount,
    form8888_attached, apply_to_estimated_tax, amount_owe, estimated_tax_penalty, yes_designee,
    no_designee, designee_name, designee_phone, designee_pin, date, occupation, identity_protection_pin,
    phone, email
) VALUES (
    1, 5000.00, 0, 0, 0, NULL, 0.00, 5000.00,
    1000.00, 0.00, 1000.00, 4000.00, 0.00, 4000.00,
    5000.00, 0.00, 0.00, 5000.00, 0.00,
    0.00, 0.00, 0.00, 0.00,
    0.00, 5000.00, 1000.00, 1000.00,
    0, 0.00, 0.00, 0.00, 1,
    0, 'Designee 1', '555-555-5555', '12345', '2024-04-15', 'Occupation 1', '123456',
    '555-555-5555', 'email1@example.com'
), (
    2, 6000.00, 0, 0, 0, NULL, 0.00, 6000.00,
    2000.00, 0.00, 2000.00, 4000.00, 0.00, 4000.00,
    6000.00, 0.00, 0.00, 6000.00, 0.00,
    0.00, 0.00, 0.00, 0.00,
    0.00, 6000.00, 2000.00, 2000.00,
    0, 0.00, 0.00, 0.00, 0,
    1, NULL, NULL, NULL, '2024-04-15', 'Occupation 2', '654321',
    '555-555-5555', 'email2@example.com'
);